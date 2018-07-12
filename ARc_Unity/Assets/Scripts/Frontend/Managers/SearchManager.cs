using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchManager : ItemManager {
    
    // variables
    private string keyword = "";
    public Text inputText;

    public SearchResult resultPrefab;
    public GameObject resultsParent;
    private List<SearchResult> results = new List<SearchResult>();

    public const string ALL = "ALL", DEP = "DEP", EMP = "EMP";
    public Text filterText;
    private string filter;

    //public const string ALPH = "ALPH", DEPF = "DEPF", EMPF = "EMPF";
    //public Text orgText;
    //private string org;

    // initialization
    protected override void Start()
    {
        base.Start();
        updateFilter();
    }

    // updating
    public void updateKeyword() {
        keyword = inputText.text;
        updateResults();
    }

    public void updateFilter() {
        filter = filterText.text;
        updateResults();
    }

    private void updateResults() {
        clearResults();

        List<Profiable> profiables;

        switch (filter)
        {
            case DEP:
                profiables = databaseManager.search(keyword, DatabaseObject.DEPARTMENT);
                break;
            case EMP:
                profiables = databaseManager.search(keyword, DatabaseObject.EMPLOYEE);
                break;
            case ALL:
                profiables = databaseManager.search(keyword);
                break;
            default:
                profiables = new List<Profiable>();
                break;
        }

        results = profiablesToResults(profiables);
    }

    private List<SearchResult> profiablesToResults(List<Profiable> profiables) {
        List<SearchResult> newResults = new List<SearchResult>();

        if (profiables != null)
        {
            foreach (Profiable profiable in profiables)
            {
                SearchResult searchResult = Instantiate(resultPrefab, transform.position, Quaternion.identity) as SearchResult;
                searchResult.setup(this, profiable, keyword);
                searchResult.transform.SetParent(resultsParent.transform, true);
            }
        }

        return newResults;
    }

    // clearing
    private void clearResults()
    {
        foreach (SearchResult result in results)
        {
            Destroy(result.gameObject);
        }
        results.Clear();
    }

}

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

    public const string DEP = "DEP", EMP = "EMP";
    public Text filterText;
    private string filter;

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
            default:
                profiables = databaseManager.search(keyword);
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

    // organizing


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

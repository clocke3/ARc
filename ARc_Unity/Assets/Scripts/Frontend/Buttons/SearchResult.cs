using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchResult : MonoBehaviour {

    private SearchManager searchManager;
    private Profiable profiable;
    private int numExtraChars;
    public DatabaseObjectButton databaseObjectButton;
    public Text labelText;

    public void setup(SearchManager searchManager, Profiable profiable, string keyword) {
        this.searchManager = searchManager;
        this.profiable = profiable;
        this.numExtraChars = Mathf.Abs(keyword.Length - profiable.getLabel().Length);

        switch (profiable.getTypeID())
        {
            case DatabaseObject.DEPARTMENT:
                labelText.text = SearchManager.DEP;
                break;
            case DatabaseObject.EMPLOYEE:
                labelText.text = SearchManager.EMP;
                break;
            default:
                break;
        }

        databaseObjectButton.setup(searchManager, profiable);

    }

    public int getNumExtraChars() {
        return numExtraChars;
    }


}

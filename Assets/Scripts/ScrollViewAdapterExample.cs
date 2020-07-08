using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewAdapterExample : MonoBehaviour
{
    public RectTransform prefab;
    public Text countText;
    public ScrollRect scrolView;
    public RectTransform content;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateItems() {
        int newCount;
        int.TryParse(countText.text, out newCount);
        StartCoroutine(FetchItemModelsFromServer(newCount, results => OnReceivedNewModels(results)));
    }

    void OnReceivedNewModels(ExampleItemModel[] models)
    {
        foreach (var child in content.transform)
        {
            Destroy(child);
        }
    }

    IEnumerator FetchItemModelsFromServer(int count, Action<ExampleItemModel[]> onDone) {

        yield return new WaitForSeconds(2f);

        var result = new ExampleItemModel[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = new ExampleItemModel();
            result[i].title = "Item " + i;
        }
    }

    public class ExampleItemModel {
        public string title;
    }
}

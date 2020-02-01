using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsGridUI : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] ToolSelector[] tools;
    int selectedTool = 0;

    private void Start() {
        foreach (var tool in tools)
            tool.Unselect();
        OnToolClick(selectedTool);
    }

    public void OnToolClick(int id) {
        if(selectedTool == id) {
            tools[selectedTool].Unselect();
            selectedTool = -1;
            gameManager.selectedTool = Tools.None;
        }
        else {
            if(selectedTool != -1)
                tools[selectedTool].Unselect();
            selectedTool = id;
            tools[selectedTool].Select();
            gameManager.selectedTool = tools[selectedTool].toolType;
        }
        
    }
}

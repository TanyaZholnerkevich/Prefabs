using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Menu : MonoBehaviour
{
    [MenuItem("Actions with the prefab/Copy")]
    public static void Copy()
    {
        var player = Selection.activeGameObject.GetComponent<Sweet>();
        player.Copy();
    }
    [MenuItem("Actions with the prefab/Delete/Original")]
    public static void DeleteOriginal()
    {
        var player = Selection.activeGameObject.GetComponent<Sweet>();
        if (player == null)
        {
            Debug.Log("Error");
        }
        player.DeleteOriginal();
    }
    [MenuItem("Actions with the prefab/Delete/Copies")]
    public static void DeleteCopies()
    {
        var player = Selection.activeGameObject.GetComponent<Sweet>();
        player.DeleteCopies();
    }
}

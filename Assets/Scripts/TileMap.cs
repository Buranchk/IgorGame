using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileMap : MonoBehaviour
{
    public int rows;
    public int columns;

    public GameObject Init;

    public void SetRows(int m_rows)
    {
        rows = m_rows;
    }

    public void SetColumns(int m_columns)
    {
        columns = m_columns;
    }

    public void CheckRowsCols()
    {
        if (rows > 1 || columns > 1)
        {
            Init.SetActive(false);
        }
        else
        {
            print("wrong numbers");
        }
    }
}

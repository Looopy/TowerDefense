using UnityEngine;
using System.Collections;

public struct Cell {
    public int x;
    public int y;
    public bool canHaveTower;
}

public class Grid : MonoBehaviour {
    Cell[,] cells;
    public GameObject cellObject;

    void Start() {
        GenerateGrid(16, 9);
    }
    void Update() {
    }

    public void GenerateGrid(int width, int height) {
        cells = new Cell[width, height];

        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                cells[x, y].x = x;
                cells[x, y].y = y;
                cells[x, y].canHaveTower = (Random.Range(0, 2) == 1);
            }
        }

        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                Instantiate(cellObject, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }
}

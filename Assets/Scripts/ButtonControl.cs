using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

public class ButtonControl : MonoBehaviour, IPointerDownHandler
{
    public Vector3 rotationPoint;
    private float previousTime;
    public float fallTime = 0.8f;
    public static int height = 21;
    public static int width = 10;
    private static Transform[,] grid = new Transform[width, height];

	public float moveSpeed = 5f;


	bool moveLeft = false;

    // Do this when the mouse is clicked over the selectable object this script is attached to.
    public void OnPointerDown(PointerEventData eventData)
    {
        moveLeft = true;
        Debug.Log(this.gameObject.name + " was clicked.");
    }

    public void OnPointerUp(PointerEventData eventData) 
    {
        moveLeft = false;
        Debug.Log(this.gameObject.name + " was released.");
    }

    void Update() 
    {
        if (moveLeft)
        {    
            transform.position += new Vector3(-1, 0, 0);
          
        }

    }


/*
    public void ShiftToLeft()
    {
        gameObject.transform.position += new Vector3(-1, 0, 0);
        if(!ValidMove())
            gameObject.transform.position -= new Vector3(-1, 0, 0);
    }

    public void SwiftToRight()
    {
        gameObject.transform.position += new Vector3(1, 0, 0);
        if (!ValidMove())
            gameObject.transform.position -= new Vector3(1, 0, 0);
    }

    public void RotateBlock()
    {
        gameObject.transform.RotateAround(gameObject.transform.TransformPoint(rotationPoint), new Vector3(0,0,1), 90);
        if (!ValidMove())
            gameObject.transform.RotateAround(gameObject.transform.TransformPoint(rotationPoint), new Vector3(0, 0, 1), -90);
    }

    public void FallDown()
    {
        if (Time.time - previousTime > (Input.GetKey(KeyCode.DownArrow) ? fallTime / 10 : fallTime))
        {
            gameObject.transform.position += new Vector3(0, -1, 0);
            if (!ValidMove())
            {
                gameObject.transform.position -= new Vector3(0, -1, 0);
                AddToGrid();
                CheckForLines();

                this.enabled = false;
                FindObjectOfType<SpawnTetromino>().NewTetromino();

            }
            previousTime = Time.time;
        }
    }

    bool HasLine(int i)
    {
        for(int j = 0; j< width; j++)
        {
            if (grid[j, i] == null)
                return false;
        }

        return true;
    }

    void DeleteLine(int i)
    {
        for (int j = 0; j < width; j++)
        {
            Destroy(grid[j, i].gameObject);
            grid[j, i] = null;
        }
    }

    void RowDown(int i)
    {
        for (int y = i; y < height; y++)
        {
            for (int j = 0; j < width; j++)
            {
                if(grid[j,y] != null)
                {
                    grid[j, y - 1] = grid[j, y];
                    grid[j, y] = null;
                    grid[j, y - 1].transform.position -= new Vector3(0, 1, 0);
                }
            }
        }
    }


    bool ValidMove()
    {
        foreach (Transform children in transform)
        {
            int roundedX = Mathf.RoundToInt(children.transform.position.x);
            int roundedY = Mathf.RoundToInt(children.transform.position.y);

            if(roundedX < 0 || roundedX >= width || roundedY < 0 ||roundedY >= height)
            {
                return false;
            }

            if (grid[roundedX, roundedY] != null)
                return false;
        }

        return true;
    }

    void AddToGrid()
    {
        foreach (Transform children in transform)
        {
            int roundedX = Mathf.RoundToInt(children.transform.position.x);
            int roundedY = Mathf.RoundToInt(children.transform.position.y);

            grid[roundedX, roundedY] = children;
        }
    }

    void CheckForLines()
    {
        for (int i = height-1; i >= 0; i--)
        {
            if(HasLine(i))
            {
                DeleteLine(i);
                RowDown(i);
            }
        }
    }
*/
}

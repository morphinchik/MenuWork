using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject[] menuList;
   
    public GameObject _menuLast;
   
    public GameObject _menuCurrent;

    public void toSaveMenu()
    {
            menuList[0].SetActive(false);
            menuList[1].SetActive(true);
            _menuCurrent = menuList[1];
            _menuLast = menuList[0];
        
    }

    public void toSearchMenu()
    {
            menuList[0].SetActive(false);
            menuList[2].SetActive(true);
            _menuCurrent = menuList[2];
            _menuLast = menuList[0];
    }

   
    public void toStartMenu()
    {
        if (_menuCurrent== menuList[1])
        {
            menuList[1].SetActive(false);
            menuList[3].SetActive(true);
            _menuLast = menuList[1];
            _menuCurrent = menuList[3];
        }
        else
        {
            menuList[2].SetActive(false);
            menuList[3].SetActive(true);
            _menuLast = menuList[2];
            _menuCurrent = menuList[3];
        }
    
    }

    public void comeBack()
    {
           GameObject tmp;
          _menuCurrent.SetActive(false);
          _menuLast.SetActive(true);
           tmp = _menuCurrent;
          _menuCurrent = _menuLast;
          if (tmp == menuList[3])
          {
               _menuLast = menuList[0];
          }
          else
          {
               _menuLast = tmp;
          }
        
        /* if (_menuLast == menuList[1] && _menuCurrent == menuList[3])
         {   
             menuList[3].SetActive(false);
             menuList[1].SetActive(true);
             _menuLast = menuList[3];
             _menuCurrent = menuList[1];
         }
         if (_menuLast == menuList[2] && _menuCurrent == menuList[3])
         {
             menuList[3].SetActive(false);
             menuList[2].SetActive(true);
             _menuLast = menuList[3];
             _menuCurrent = menuList[2];
         }
         if (_menuCurrent == menuList[1] && _menuLast == menuList[0] )
         {
             menuList[1].SetActive(false);
             menuList[0].SetActive(true);
         }
         if (_menuCurrent == menuList[2] && _menuLast == menuList[0])
         {
             menuList[2].SetActive(false);
             menuList[0].SetActive(true);
         }*/

    }

}

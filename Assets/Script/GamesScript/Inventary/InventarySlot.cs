using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventarySlot : MonoBehaviour
{

    public ItemScripteblObject item; // ��� ����� ������ � �����. 
    public int amount; // ������� ���������� ���������, � �����
    public bool isEmpty = true;// ������ ������ ��� ���
    public GameObject iconGO; // �������� ��� ����� ����� ������������ �������� ��������� � ������ 
    public TMP_Text ItemAmountText;// ���������� � ������(������)  
    public int IdSlot;




    private void Awake()
    {
        iconGO = transform.GetChild(0).GetChild(0).gameObject; // �������� � iconGo ��������� �������� ������� ����� ������������ � �����, ����� 0 
        //������� � ���������  ������, � 0 ���� ���������


        ItemAmountText = transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>();// ���� ����� 
        
    }
    

    



    public void SetIcon(Sprite icon) // ��� ��������� �������� 
    {
        iconGO.GetComponent<Image>().color = new Color(1, 1, 1, 1); // ��� �������� ����������� ��������
        iconGO.GetComponent<Image>().sprite = icon; // �� ����� ���� �������� 
    }
}

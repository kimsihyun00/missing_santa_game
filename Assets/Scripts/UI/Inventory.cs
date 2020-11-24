using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum Items
{
    OLD_BOOK,
    KEY,
    BUTTONS,
    TOWEL,
    CARROT,
    RULERS,
    POTION,
    COIN,
    HAMBURGER
};

public class Inventory : MonoBehaviour
{
    // Inventory Panel Handle
    public GameObject[] ItemImages = new GameObject[10];
    public GameObject[] InventoryImages = new GameObject[10];

    public Sprite[] ItemSprites = new Sprite[10];
    public Sprite[] InventorySprites = new Sprite[2];

    public Text ItemNameText;
    public Text ExplanationText;
    public Image ItemSelectImage;

    string[] ItemNames = { "고서", "열쇠", "단추", "타올", "당근", "큰 자", "물약", "동전", "햄버거" };
    string[] ItemExplanation =
    {
        "슬쩍 보아도 낡아 보이는 책이다.\n해석할 수 없는 문자로 되어있으며\n한쪽 아래에 루돌프가 그려져 있다.",
        "남이의 양말에서 발견한 열쇠이다.\n남이는 자신의 것이 아니라고 하는데\n 어디에 쓰이는 걸까...?",
        "화장실에서 발견한 단추 2개이다.\n검은색 두 알이 눈사람의 눈이 될 수 있을까?",
        "기다란 타올이다.\n눈사람의 목이 허전할까 챙겨뒀는데\n 눈사람의 목에 걸어주면 좋아하겠지?",
        "제법 눈사람의 코처럼 생긴 당근이다.\n보라 말로는 눈사람의 코는 대부분 당근이라던데...",
        "크고 단단한 자 2개이다.\n이걸 어디에 쓸 수 있을까...?",
        "마녀 언니로부터 받은 물약이다.\n생명을 줄 수 있다던데...\n무엇에 생명을 줘야 할까?",
        "동전이다.\n이 마을 어딘가에 돈을 쓸 수 있는 곳이 있을 거야!",
        "키오스크에서 뽑은 햄버거이다.\n이 햄버거를 누구에게 줘야 할까?"
    };
    int[] InventoryItems = { 0, 1, 2, 3, 4, 5, 6, 7, 8, -1 };
    int InventoryClickedNum = -1;
    
    public void BagBtnClicked()
    {
        for (int i = 0; i < InventoryItems.Length; i++)
        {
            if (InventoryItems[i] != -1)
            {
                int itemIndex = InventoryItems[i];
                ItemImages[i].SetActive(true);
                ItemImages[i].GetComponent<Image>().sprite = ItemSprites[itemIndex];
            }
        }
    }
    
    public void Inventory1BtnClicked()
    {
        InventoryClickedNum = 0;
        InventoryClicked();
    }

    public void Inventory2BtnClicked()
    {
        InventoryClickedNum = 1;
        InventoryClicked();
    }

    public void Inventory3BtnClicked()
    {
        InventoryClickedNum = 2;
        InventoryClicked();
    }

    public void Inventory4BtnClicked()
    {
        InventoryClickedNum = 3;
        InventoryClicked();
    }

    public void Inventory5BtnClicked()
    {
        InventoryClickedNum = 4;
        InventoryClicked();
    }

    public void Inventory6BtnClicked()
    {
        InventoryClickedNum = 5;
        InventoryClicked();
    }

    public void Inventory7BtnClicked()
    {
        InventoryClickedNum = 6;
        InventoryClicked();
    }

    public void Inventory8BtnClicked()
    {
        InventoryClickedNum = 7;
        InventoryClicked();
    }

    public void Inventory9BtnClicked()
    {
        InventoryClickedNum = 8;
        InventoryClicked();
    }

    public void Inventory10BtnClicked()
    {
        InventoryClickedNum = 9;
        InventoryClicked();
    }

    void InventoryClicked()
    {
        int itemIndex = InventoryItems[InventoryClickedNum];
        for (int i = 0; i < InventoryImages.Length; i++)
        {
            if (i == InventoryClickedNum)
                InventoryImages[i].GetComponent<Image>().sprite = InventorySprites[1];
            else
                InventoryImages[i].GetComponent<Image>().sprite = InventorySprites[0];
        }

        ItemSelectImage.sprite = ItemSprites[itemIndex];
        ItemNameText.text = ItemNames[itemIndex];
        ExplanationText.text = ItemExplanation[itemIndex];
    }
}

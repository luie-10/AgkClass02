using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListPracice : MonoBehaviour
{
    //문자열을 저장하는 리스트 생성
    [SerializeField] private List<string> inventory = new List<string>();

    //검사할 문자열 ( string.Empty = 문자열이 없다 )
    public string checkStr = string.Empty;
    // Start is called before the first frame update
    void Start()
    {
        inventory.Add("dd");
        inventory.Add("검");
        inventory.Add("방패");
        
        Debug.Log("아이템 3개를 추가했습니다.");

        // 현재 인벤토리 출력

        for(int i =0; i < inventory.Count; i++)
        {
            Debug.Log($"{i+1}번째 아이템 : {inventory[i]}");
        }

        inventory.Remove("dd");
        //inventory.RemoveAt(0);

        Debug.Log("포션을 사용해서 제거했습니다.");



        // 삭제 후 인벤토리 목록 호출
        for (int i =0; i < inventory.Count;i++)
        {
            Debug.Log($"{i + 1}번째 아이템 : {inventory[i]}");
        }

        // 리스트.Contains( 확인할 요소 ) => 반환형 bool (true & false )
        if (inventory.Contains(checkStr))
        {
            Debug.Log($"{checkStr}이 있습니다.");
        }
        else
        {
            Debug.Log($"{checkStr}이 없습니다.");
        }
    }
}

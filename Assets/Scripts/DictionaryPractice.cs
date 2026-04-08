using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryPractice : MonoBehaviour
{
    // 왼쪽이 키고 , 오른쪽이 값입니다.
    //string이 키의 자료형,int는 값의 자료형이며 library는 바꿔도 되는 이름이다.
    // 키와 값의 자료형엔 제한이 없습니다.
    public Dictionary<string, int> library = new Dictionary<string, int>();

    void Start()
    {
        // 딕셔너리 값 추가 (딕셔너리 이름.Add(키, 값))
        library.Add("해리포터", 3);
        library.Add("라오루", 5);
        library.Add("어린 왕자", 2);
        //딕셔너리 값 변경 ( 딕셔너리 이름[키] = 변경할 값 )

        library["해리포터"] = 2;
        
        //처음부터 끝까지 돈다. (탐색)
        // 컬렉션
        // foreach(데이터 타입 변수명 in 컬렉션) book안에 library를 넣는다.
        foreach(KeyValuePair<string, int> book in library)
        {
            Debug.Log("책 제목 : " + book.Key + "재고"  + book.Value);
        }
        if (library.ContainsKey("해리포터"))
        {
            Debug.Log("해리포터의 현재 재고" + library["해리포터"]);
        }

        library["해리포터"]++;

        // 책을 대출하는 걸 만들어봐요

        string borrowBook = "해리포터";

        if (library.ContainsKey(borrowBook))
        {
            if (library[borrowBook] > 1)
            {
                print("책을 빌립니다...");
                library[borrowBook]--;
                Debug.Log("바뀐" + borrowBook + " 의 현재 재고" + library[borrowBook]);
            }
        }
        if (library.ContainsKey(borrowBook))
        {
            print("책을 반납합니다.");
            library[borrowBook]++;
            Debug.Log("바뀐" + borrowBook + " 의 현재 재고" + library[borrowBook]);
        }
        //int[] arr = new int[3];
        //foreach ( int i in arr )
        
       
    }

}

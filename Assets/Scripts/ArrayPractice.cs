using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ArrayPractice : MonoBehaviour
{
    //점수를 저장할 int 배열 생성
    public int[] scores = new int[4];
    // Start is called before the first frame update
    void Start()
    {
        //배열의 각 칸에 점수 넣기
        scores[0] = 60;
        scores[1] = 70;
        scores[2] = 55;
        scores[3] = 89;

        // 총합을 저장할 변수
        int sum = 0;
        int maxScore = 0;

        Debug.Log("배열 실습");
        // 배열의 모든 값을 출력하면서 총합과 최고점수 구하기
        for (int i = 0; i < scores.Length; i++)
        {
            Debug.Log($"{i+1}번째 점수 : {scores[i]}");
            // 총합에 현재 점수 구하기
            sum += scores[i];

            //현재 점수가 최고 점수보다 크면 최고 점수 갱신
            if (scores[i] > maxScore)
            {
                maxScore = scores[i];
            }
            
        }
        // 형변환
        float average = (float)sum / scores.Length;
        print("총합 : " + sum);
        print("평균 :  " + average);
        Debug.Log("최고 점수 : " + maxScore);

        int a = 0;
        a = sum / scores.Length;
        print("평균 :  " + a);
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}

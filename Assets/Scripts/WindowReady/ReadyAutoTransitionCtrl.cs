// using System.Collections;
// using TMPro;
// using UnityEngine;

// /// <summary>
// /// Ready -> Select
// /// 입력 없을 때 자동으로 전환되는 컨트롤러
// /// </summary>
// public class ReadyAutoTransitionCtrl : MonoBehaviour
// {
//     [Header("Timer Settings")]
//     [SerializeField] private float _startSeconds = 10f;      // 시작 카운트 값 (기본 10초)

//     [Header("Runtime")]
//     [SerializeField] private float _timer;                   // 현재 남은 시간
//     [SerializeField] private TextMeshProUGUI _timerText;     // 타이머 텍스트

//     private Coroutine _timerRoutine;

//     /// <summary>
//     /// [외부 호출용] 자동 전환 카운트다운 시작
//     /// </summary>
//     public void AutoTransitionTimer()
//     {
//         // 이미 돌고 있으면 먼저 정지 후 다시 시작 (리셋 느낌)
//         if (_timerRoutine != null)
//         {
//             StopCoroutine(_timerRoutine);
//             _timerRoutine = null;
//         }

//         _timerRoutine = StartCoroutine(TimerRoutine());
//     }

//     private IEnumerator TimerRoutine()
//     {
//         _timer = _startSeconds;

//         while (_timer > 0f)
//         {
//             int display = Mathf.CeilToInt(_timer);

//             if (_timerText != null)
//                 _timerText.text = display.ToString();

//             yield return new WaitForSeconds(1f);
//             _timer -= 1f;
//         }

//         // 마지막 0 표시
//         if (_timerText != null)
//             _timerText.text = "0";

//         // Debug.Log("호출!");

//         _timerRoutine = null;

//         // 타이머 텍스트 초기화
//         _timerText.text = "";
//         // 나중에 여기에서 실제 패널 전환 호출        
//     }
// }

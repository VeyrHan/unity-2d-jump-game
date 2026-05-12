using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class AllControl : MonoBehaviour
{
    public class GameManager
    { 
        //单例模式
        private static GameManager _instance;

        public static GameManager Instance
        {
            get
            { 
                if(_instance==null)
                    _instance = new GameManager();
                return _instance;
            }
        }
        //计分板数据
        public int totalscore = 0;
        public int score = 0;
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    
}

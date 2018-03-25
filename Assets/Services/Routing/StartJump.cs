using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartJump : MonoBehaviour {
    [SerializeField] string path;

    void Start() {
        TopLevelRouter.JumpTo(path);
    }
}
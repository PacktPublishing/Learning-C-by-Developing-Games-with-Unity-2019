using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1
public interface IManager 
{
    // 2
    string State { get; set; }

    // 3
    void Initialize();
}
using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class Test : MonoBehaviour
{

    private  void Start()
    {
        int [] arrs = new int [] { 1, 2, 3 ,4,5,6};   
        Max(arrs,0,5);


    }



    


    public int Max(int [] arrays,int leftRange,int rightRange)
    {
        if(arrays == null || arrays.Length==0)return 0;

        if (rightRange - leftRange == 0) return arrays[leftRange];

        if(rightRange-leftRange==1)
        {
            return arrays[rightRange] > arrays[leftRange] ?arrays[rightRange] : arrays[leftRange];
        }


        int middle = (rightRange - leftRange) / 2 + leftRange;

        //找出左边最大值   

        int maxLeft = Max(arrays,leftRange,middle);

        //找出右边最大值

        int maxRight = Max(arrays, middle,rightRange);



        return maxLeft > maxRight ? maxLeft : maxRight;


    }
  
    int fib(int n)
    {
        Debug.Log(n);
        if(n==1) return 1;
       
        if(n==2)return 1;

        return fib(n-1) + fib(n-2);
    }
}

public static class Extension
{
    
}


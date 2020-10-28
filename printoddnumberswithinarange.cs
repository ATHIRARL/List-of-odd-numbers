using System;
using System.Collections.Generic;
using System.Linq;
public class A
{
	public static void Main()
	{
		int l=5;
		int r=10;
		
		var c=oddNumbers(l,r);
		foreach(var d in c)
		{
			Console.WriteLine(d);
		}
			
	}

		
 static List<int> oddNumbers(int l, int r)
    {
	 
       List<int> odd = new List<int>();
	 for(int i=l;i<r;i++)
	 {
		 odd.Add(i);
	 }
    //if (l % 2 == 0)
      //  l++;
    //while(l <= r) {/}
	var s = odd.Where(a => a % 2 != 0).ToList();
    return s;
 }
}

		

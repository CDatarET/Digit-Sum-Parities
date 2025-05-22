using System;

public class Test
{
    public static int add(int n){
        int ret = 0;
        while(n != 0){
            ret = ret + n%10;
            n = n/10;
        }
        return(ret);
    }
    
	public static void Main()
	{
		int cases = int.Parse(Console.ReadLine());
		for(int c = 0; c < cases; c++){
		    int n = int.Parse(Console.ReadLine());
		    int x = n + 1;
		    n = add(n);
		    
		    bool nP = (n%2 == 0);
		    bool check = nP;
		    
		    while(nP == check){
		        check = (add(x) % 2 == 0);
		        if(check != nP){
		            break;
		        }
		        else{
		            x++;
		        }
		    }
		    
		    Console.WriteLine(x);
		}
	}
}

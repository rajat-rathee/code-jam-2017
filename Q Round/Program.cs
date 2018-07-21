using System;
using System.Collections.Generic;
using System.IO;
class countingsheep {
	static void Main(string[] args){
		List<int> list = new List<int>();
		using (StreamReader reader = new StreamReader("input.txt")){
			string line;
			while((line = reader.ReadLine()) != null){
				list.Add(int.Parse(line));
			}
		}
		int t = list[0];
		int count =2;
		int change;
		bool solved = false;
		for(int i=1; i<=t;i++){
		List<int> seen = new List<int>();
		if (list[i] = 0){
			Console.WriteLine("Case #" +i+ ": INSOMNIA");
		}
		else{
			int num = list[i];
			while(solved == false){
				while(num>0){
					int dig = num%10;
					seen.Add(dig);
					num /= 10;
			}
			if(seen.Contains(1) && seen.Contains(2)&& seen.Contains(3)&& seen.Contains(4)&& seen.Contains(5)&& seen.Contains(6)&& seen.Contains(7)&& seen.Contains(8)&& seen.Contains(9)&& seen.Contains(0)){
				solved = true;
			}
			else{
				num = num*count;
				count++;
			}
		}

		}
		Console.WriteLine("Case #" +i+ ": " + num);
		}
	}
}
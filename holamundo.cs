/*

//FIBONACCI
using System;

class Program {

  
  public static void Main (string[] args) {
    int first=0;
    int aux=1;
    int step=Convert.ToInt32(Console.ReadLine());
    int a;
    while(true){
      a=aux;
      aux=first+aux;
      first=a;
      if(aux==step){
        Console.WriteLine("Yes");
        break;
      }else if (aux>step){
        Console.WriteLine("No");
        break;
      }else{
        continue;
      }
    }
  } 
  
}


//LETRAS

using System;

class Program {

  
  public static void Main (string[] args) {
    string word=Console.ReadLine();
    char[] aux=new char[word.Length];
    for(int i=0; i<word.Length;++i){
      int le=(int)word[i];
      //numbers
      Console.WriteLine(le);
      if (le>48 && le<58 ){ 
        aux[i]=(char)le;
      //vocales minusculas
      }else if(le+1==97 || le+1==101 || le+1==111 || le+1==105 || le+1==117){
          aux[i]=((char)(le+1-32));
      //vocales mayusculas
      }else if(le+1==97-32 || le+1==101-32 || le+1==105-32 || le+1==117-32 ){
         aux[i]=((char)(le+1+32));
      }
      else if((le>96 && le<122 )){
        aux[i]=((char)(le+1));
      //letras mayusculas
      }else if((le>64 && le<90)){
        aux[i]=((char)(le+1));
      }else if(le==122){
        aux[i]=(char)(le-25-32);
      }else if(le==90){
        aux[i]=(char)(le-25);        
      }else{
      aux[i]=word[i];
      }
    }
    string result=new string(aux);
    Console.WriteLine(result);
  } 
  
}


//Contador de palabras
using System;

class Program {
  
  public static void Main (string[] args) {
    Console.WriteLine("-----");
    string word=Console.ReadLine();
    Console.WriteLine("-----");
    string find=Console.ReadLine();
    find=find.ToLower();
    countWord(word,find);
  } 
  static void countWord(string a, string z){
    a=a.Replace(".",string.Empty).ToLower();
    string[] b = a.Split(' ');
    int count=0;
    foreach(string aux in b ){
      if(z==aux){
        ++count;
      }
    }
    Console.WriteLine(count);
  }
}

*/

using System;

class Program {
  
  public static void Main (string[] args) {
    string word=Console.ReadLine();
    char[] arr1= new char[word.Length];
    int[] arr2= new int[word.Length];
    int count=0;
    for(int i=0; i<word.Length;++i){
      char aux=(char)word[i];
      if((aux<'A' && aux>'Z') || (aux<'a' && aux>'z')){
        arr1[i]=aux;
        ++count;
      }else{
        arr1[i]=' ';
      }
    }
    for(int i=0; i<word.Length-count;++i){
      char aux=(char)word[i];
      if((aux<'A' && aux>'Z') || (aux<'a' && aux>'z')){
        continue;
      }else{
        arr2[i]=(int)aux;
      }
    }
    for(int i=0;i <arr2.Length-1;++i){
      for(int j=i+1;j<arr2.Length;++j){
        if(arr2[i]>arr2[j]){
          int aux_arr=arr2[i];
          arr2[i]=arr2[j];
          arr2[j]=aux_arr;
        } 
      }
    }
    int count2=0;
    for(int i=0;i <arr1.Length;++i){
      if(arr1[i]==' '){
        arr1[i]=(char)arr2[i+count];
      }else{
        count2++;
      }
    }
  } 
  
}


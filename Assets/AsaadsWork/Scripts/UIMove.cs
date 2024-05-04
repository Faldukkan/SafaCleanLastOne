
using UnityEngine;

public class UIMove : MonoBehaviour
{
     public float speed = 5f; 
    public GameObject Lifter;
    
    public AudioSource audioSource;
    private bool is_clickedd=false;
     int choose=0;

public void is_clicked(){
is_clickedd=true;
}
public void is_notclicked(){
is_clickedd=false;

}
private void Update() {
if(is_clickedd){
    switch(choose) {
        case 1:
        Lifter.transform.Translate(Vector3.right * speed * Time.deltaTime); 
        
        break;
        case 2:
        Lifter.transform.Translate(Vector3.left * speed * Time.deltaTime);  
        break;
        case 3:
        Lifter.transform.Translate(Vector3.up * speed * Time.deltaTime);  
        break;
        case 4:
        Lifter.transform.Translate(Vector3.down * speed * Time.deltaTime);  
        break;
    }
    
}

    
}
public void Onturnright(){
    is_clicked();
    audioSource.Play(); 
    choose=1;
      

}
    
    public void Onturnrleft(){
         is_clicked();
       choose=2;
 
}
public void OnUp(){
        is_clicked();

     choose=3;
    
}
public void OnDown(){
        is_clicked();
     choose=4;
 
}
public void Ofturnright(){

    is_notclicked();
}


public void Ofturnleft(){

    is_notclicked();
}
 
 
public void OfUp(){

    is_notclicked();
}

public void OfDown(){

    is_notclicked();
}

}

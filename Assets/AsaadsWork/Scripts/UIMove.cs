
using UnityEngine;

public class UIMove : MonoBehaviour
{
     public float speed = 5f; 
    public GameObject truck;
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
        truck.transform.Translate(Vector3.right * speed * Time.deltaTime);  
        break;
        case 2:
        truck.transform.Translate(Vector3.left * speed * Time.deltaTime);  
        break;
        case 3:
        truck.transform.Translate(Vector3.up * speed * Time.deltaTime);  
        break;
        case 4:
        truck.transform.Translate(Vector3.down * speed * Time.deltaTime);  
        break;
    }
    /*if (choose==1){
        truck.transform.Translate(Vector3.right * speed * Time.deltaTime);  
    }
    else if(choose==2){
           truck.transform.Translate(Vector3.right * speed * Time.deltaTime); 
    }
    else if(choose==3){
       truck.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    else if(choose==4){
      truck.transform.Translate(Vector3.right * speed * Time.deltaTime);  

    }*/
}

    
}
public void Onturnright(){
    is_clicked();
    choose=1;
    //truck.transform.Translate(Vector3.right * speed * Time.deltaTime);  

}
    
    public void Onturnrleft(){
         is_clicked();
       choose=2;
//truck.transform.Translate(Vector3.right * speed * Time.deltaTime);  
}
public void OnUp(){
        is_clicked();

     choose=3;
    //truck.transform.Translate(Vector3.right * speed * Time.deltaTime);  
}
public void OnDown(){
        is_clicked();
     choose=4;
    //truck.transform.Translate(Vector3.right * speed * Time.deltaTime);  
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

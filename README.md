1.ความเป็นมาของโปรแกรม
```
ปัญหาคือ มีผู้คนจำนวนมากที่ต้องการเดินทางให้สะดวกสบายโดยการขับขี่จักรยานไปมหาวิทยาลัยหรือต้องการที่จะออกกำลังกายแต่ไม่มีจักรยานที่จะใช้ขับขี่ จึงออกแบบจัดทำขึ้นมาให้ยืมได้สะสวกสบายและรวดเร็วต่อการยืมจักรยาน
```
2.วัตถุประสงค์ของโปรแกรม
``` 
1) เพื่อให้ผู้ที่ต้องการขับขี่จักรยาน
2) สามารถยืมได้ง่ายสะดวกสบาย
3) มีหลากหลายรุ่นให้เลือก
4) มีการเก็บข้อมูลของผู้ยืมเพื่อที่จะนำไปต่อยอด
5) มีการออกบินค่าใช้จ่ายในการยืม
6) เพื่อให้ผู้ที่ต้องการมีสุขภาพร่างกายแข็งแรงจึงได้จัดทำขึ้น
```
3.โครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม ใช้ Mermaid ในการเขียน ตัวอย่าง การเขียน Classdiagram ใน Markdown   
```mermaid
classDiagram
  direction LR
  class Mainpage{
  -Exit():void
  -Start():void
}

class Infomation{
  -Add():void
  -Return():void
  -Delete():void
  -Save():void
  -Exit():void
  -Model():void
  -Payment():void
  -Login():void
}

  class Users{
  -Manage():void
  -Name():void
  -CardID():void
  -Mail():void
  -Phone():void
  -Date():void
  -Time():void
}

  class Bike1{
  +Bike1():void
}

  class Bike2{
  +Bike2():void
}

  class Bike3{
  +Bike3():void
}

  class Bike4{
  +Bike4():void
}

  class Bike5{
  +Bike5():void
}

  class Bike6{
  +Bike6():void
}

  class Bike7{
  +Bike7():void
}

  class Bike8{
  +Bike8():void
}

  class Bike9{
  +Bike9():void
}
  class Product{
  -Name():void
  -Price():void
  -Image():void
}

  class Model{
  -Exit():void
  -Rent():void
  -Delete():void
  -Infomation():void
  -Payment():void
  -Login():void
}
  class Payment{
  -Exit():void
  -Print():void
  -Infomation():void
  -Model():void
  -Login():void
}  
  Product -- Payment
  Users -- Infomation
  Product -- Model
  Loading -- Mainpage
  Mainpage -- Infomation
  Infomation -- Model
  Model -- Payment
  Product -- Bike1
  Product -- Bike2
  Product -- Bike3
  Product -- Bike4
  Product -- Bike5
  Product -- Bike6
  Product -- Bike7
  Product -- Bike8
  Product -- Bike9
```
4.ชื่อของผู้พัฒนาโปรแกรม
```
นาย ปฏิพัทธ์ มาตรา 653450293-2
```

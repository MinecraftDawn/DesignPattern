# Observer Pattern (觀察者模式)
### 簡述
> 可以定義觀察機制，當被觀察物件狀態改變時，觀察者可以收到通知並做出相對應動作

### 目的
> 降低物件之間耦合性。被觀察者與觀察者的一對多關係，使其可自動通知所有訂閱者

### UML
![](https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Observer_w_update.svg/800px-Observer_w_update.svg.png)

### 優點
1. 降低耦合性
1. 可異步通知
1. 擴展性佳
1. 符合Open/Closed Principle
1. 可在運行時建立觀察

### 缺點
1. 過度使用可能造成程式碼變複雜
1. 通知順序難以控制
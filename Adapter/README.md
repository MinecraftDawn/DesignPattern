# Adapter Pattern (轉接器模式)

### 簡述
> 將一個介面轉換為另一種介面，讓原本不相容的接口能正常使用
### 目的
> 提供兩個不相容的介面之間的橋樑

### UML
![](https://upload.wikimedia.org/wikipedia/commons/e/e5/W3sDesign_Adapter_Design_Pattern_UML.jpg)

### 優點
1. 符合Single Responsibility Principle
1. 符合Open/Closed Principle
1. 降低耦合，使用者不需要瞭解被轉接的細節
1. 增加靈活性

### 缺點
1. 需要引入一組新的類別，造成程式碼變複雜
1. 轉接可能導致性能降低
1. 
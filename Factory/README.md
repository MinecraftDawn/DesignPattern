# 工廠模式 (Factory Pattern)

### 簡述
> ***撰寫一個用來建立物件的介面，並撰寫類別繼承該介面，用以實例化類別***

### 目的
> ***實例化類別常是複雜的過程，可能造成多處重複的程式碼，工廠模式提供單一方法來處理實例化類別的問題。***

### UML

![](https://upload.wikimedia.org/wikipedia/commons/4/43/W3sDesign_Factory_Method_Design_Pattern_UML.jpg)


### 優點
1. 避免創造物者與實例產品間的耦合性

2. 符合Single-responsibility principle

3. 符合Open–closed principle

4. 可以更方便新增不同的類別，提高系統靈活性


### 缺點
1. 程式碼可能變複雜

# 單例模式 (Singleton Pattern)

### 簡述
> ***保證類別只產生一個物件，提供一個簡單存取的全域存取方式***

### 目的
> ***確保唯一性***


### UML
![](https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/Singleton_UML_class_diagram.svg/220px-Singleton_UML_class_diagram.svg.png)

### 優點
1. 任何位置都能輕鬆的全域存取
2. 節省資源
3. 撰寫得宜可執行緒安全

### 缺點
1. 違反Single Responsibility Principle
2. 多執行緒需要特殊處理
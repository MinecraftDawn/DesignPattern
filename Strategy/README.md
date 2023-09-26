# Strategy Pattern (策略模式)

### 簡述
> 將不同演算法包裝成類別並繼承同一介面，使其可以互換使用

### 目的
> 多個演算法能交替使用，提供靈活性。

### UML
![](https://upload.wikimedia.org/wikipedia/commons/4/45/W3sDesign_Strategy_Design_Pattern_UML.jpg)

### 優點
1. 將演算法細節與使用分開
1. 可維護性、可重用性較高
1. 可以透過組合代替繼承
1. 符合Open/Closed Principle，不修改內容即可擴增

### 缺點
1. 只有少數演算法包裝成策略模式，容易顯得程式碼變複雜
1. 使用者需要了解策略差異才能正確做選擇
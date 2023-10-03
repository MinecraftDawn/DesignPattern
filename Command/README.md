# Command Pattern (命令模式)

### 簡述
> 將請求封裝成物件，允許參數化客戶端操作，可支援延遲、佇列等方式來處理請求。

### 目的
> 避免請求和連線的耦合，並依照請求可調整物件

### UML
![](https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Command_pattern.svg/800px-Command_pattern.svg.png)

### 優點
1. 符合Single Responsibility Principle
1. 符合Open/Closed Principle.
1. 可以undo/redo
1. 可以延遲處理
1. 可將簡單的命令組合成複雜的命令
1. 降低耦合

### 缺點
1. 程式碼變複雜
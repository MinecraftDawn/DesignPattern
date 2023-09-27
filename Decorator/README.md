# Decorator Pattern (裝飾者模式)

### 簡述
> 動態在類別中添加新的行為，相對於生成子類別更加靈活

### 目的
> 動態擴展功能，不需要修改原始碼提供新的功能

### UML
![](https://upload.wikimedia.org/wikipedia/commons/thumb/e/e9/Decorator_UML_class_diagram.svg/757px-Decorator_UML_class_diagram.svg.png)


### 優點
1. 靈活性高
1. 不用寫過多子類別
1. 程式碼簡潔
1. 符合Single Responsibility Principle

### 缺點
1. 多個裝飾器可能會讓程式碼結構變複雜
1. 較不易理解
1. 很難從裝飾者堆疊中刪除特定功能
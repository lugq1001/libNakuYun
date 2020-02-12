# libNakuYun

#### 文件目录
- **libNakuYun.exe**. 外部调用文件
- **sample.bat**. 命令行示例
- **NakuYunApp.msi**. NakuYunAp安装文件

#### Required
| .Net Framework 4.5.2+| 
|---------------|

#### Usage
```c#
/// CMD
libNakuYun.exe -print "D:\text.txt" 1 4 0

# 参数:
-print [FilePath] [Copy] [Paper] [Side]

[FilePath]:文件绝对路径
[Copy]:打印份数
[Paper]:纸张类型
0 : A0,
1 : A1,
2 : A2,
3 : A3,
4 : A4,
5 : A5,
6 : A6,
7 : A7,
8 : A8,
9 : A9,
10 : B0,
11 : B1,
12 : B2,
13 : B3,
14 : B4,
15 : B5,
16 : B6,
17 : B7,
18 : B8,
19 : B9,
20 : B10,
21 : C3,
22 : C4,
23 : C5,
24 : C6

[Side]：单/双面
0 : 单面
1 : 双面 旋转长边页面
2 : 双面 旋转短边页面

***
# 返回值如下: 
// "0::success"; 
// "1::NakuYun Not Found."
// ...

```

#### 返回值说明

|code|message||
|---------------|---------------|---------------|
|0| success|调用成功<br>-当NakuYunApp未启动时，会主动唤起App，并调用打印。<br>-当NakuYunApp启动时，会直接调用打印。<br>**目前NakuYunApp打印功能未完成，调用后通过右下角任务栏气泡表示调用成功**
|1| NakuYun Not Found.|未发现NakuYunApp安装路径
|2| NakuYun Not Installed.|未发现NakuYunApp程序
|3| Print File Not Found.|打印文件路径错误
|4| Args Invalid.|参数错误
|-1|{Exception.Message}|代码异常

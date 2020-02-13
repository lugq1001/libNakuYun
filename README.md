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
libNakuYun.exe -print "D:\text.txt" 1 4 1 1

# 参数:
-print [Path] [Copies] [PaperSize] [Orientation] [Color]

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

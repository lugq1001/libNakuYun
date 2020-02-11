# libNakuYun

#### 文件目录
- **libNakuYun.dll**. C#动态链接库，用于调用NakuYunApp
- **DLLSample.exe**. 演示程序
- **DLLSample**. 演示程序工程
- **NakuYunApp.msi**. NakuYunAp安装文件

#### Required
| .Net Framework 4.5.2+| 
|---------------|

#### Usage
```c#
# using libNakuYun;
# using libNakuYun.Print;

 
1.构造打印设置
PrintPreference preference = new PrintPreference
{
    // 打印份数
    copy = 1,
    // 纸张类型
    paperKind = PrintPreference.PaperKind.A4,
    // 单双面
    side = PrintPreference.Side.OneSide
};

 
2.创建打印任务
/// <param name="filePath">本地文件绝对路径</param>
/// <param name="preference">打印设置</param>
PrintTask task = new PrintTask(@"C:\test.pdf", preference);


3.调用打印
/// <param name="task">目前仅存在PrintTask</param>
/// <returns>
/// 以{code}::{message}格式返回字符串
/// </returns>
string result = NakuYun.Invoke(task);
// 返回值如下: 
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
|-1|{Exception.Message}|代码异常

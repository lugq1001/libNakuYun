@Echo off
pushd %~dp0
rem -print [文件绝对路径] [打印份数] [纸张类型] [方向] [颜色]]
libNakuYun.exe -print "D:\text.txt" 1 1 1 1
popd
TIMEOUT /T -1 /NOBREAK
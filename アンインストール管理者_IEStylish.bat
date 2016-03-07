REM call "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\Tools\VsDevCmd.bat"
cd /d %0\..
REM gacutil /u IEStylish.dll
regasm /u IEStylish.dll
pause

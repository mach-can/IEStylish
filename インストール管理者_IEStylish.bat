REM call "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\Tools\VsDevCmd.bat"
REM �J�����g�t�H���_�ֈړ�
cd /d %0\..
REM original
REM gacutil /if IEStylish.dll
regasm IEStylish.dll
pause

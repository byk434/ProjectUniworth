@ECHO OFF
ECHO ProjectUniworth


set testcategory=INVALID
set dllpath=C:\Users\Hp\Source\Repos\ProjectUniworth\ProjectUniworth\bin\Debug\ProjectPOMWriteMethod.dll

set SummaryReportPath=C:\Users\Hp\Source\Repos\ProjectUniworth\ProjectUniworth\SummaryReportPath



call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe  %dllpath%  /Logger:"trx;LogFileName=%SummaryReportPath%\babar.trx"

cd C:\Users\Hp\Source\Repos\ProjectUniworth\ProjectUniworth\bin\Debug

TrxToHTML %SummaryReportPath%

PAUSE
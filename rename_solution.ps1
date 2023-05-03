Write-Host "Renaming solution..."
Write-Host ""

Get-ChildItem -File -Recurse | % { Rename-Item -Path $_.PSPath -NewName $_.Name.replace("Packeta","Packeta")}

$null = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown');
[CmdletBinding()]
param(
    [string]$ProjectRoot = (Split-Path -Parent $PSScriptRoot),
    [string]$ConfigFile = "Doxyfile",
    [switch]$OpenIndex
)

$ErrorActionPreference = "Stop"

$doxygen = Get-Command doxygen -ErrorAction SilentlyContinue
if (-not $doxygen) {
    throw "doxygen was not found. Make sure doxygen.exe is installed and available on PATH."
}

$configPath = Join-Path $ProjectRoot $ConfigFile
if (-not (Test-Path -LiteralPath $configPath)) {
    throw "Doxygen config file not found: $configPath"
}

Push-Location $ProjectRoot
try {
    & $doxygen.Source $configPath
    if ($LASTEXITCODE -ne 0) {
        throw "Doxygen generation failed with exit code: $LASTEXITCODE"
    }

    $indexPath = Join-Path $ProjectRoot "docs\doxygen\html\index.html"
    if (-not (Test-Path -LiteralPath $indexPath)) {
        throw "Doxygen finished, but the output index was not found: $indexPath"
    }

    Write-Host "Doxygen manual generated:" -ForegroundColor Green
    Write-Host $indexPath

    if ($OpenIndex) {
        Start-Process $indexPath | Out-Null
    }
}
finally {
    Pop-Location
}

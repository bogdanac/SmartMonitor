Get-AzureVM |

Where-Object {$_.status -ne "StoppedDeallocated"} |

Stop-AzureVM -Force

#Remove-AzureRmResourceGroup -Name "SmartMonitorVM"
$mailTo = New-Object "System.Collections.Generic.List[String]" 
$mailTo.Add(“bogdana.carausan@endava.com”)
$action = New-AzureRmAlertRuleEmail -CustomEmail $mailTo  
$action.SendToServiceOwners = $true  
Add-AzureRmMetricAlertRule -Location “westeurope” -MetricName “Percentage CPU” -Name “Percentage CPU” -Operator GreaterThan -ResourceGroup “SmartMonitorVM” -TargetResourceId “/subscriptions/a329319b-9a69-4749-9a2a-c70db554f0a1/resourceGroups/SmartMonitorVM/providers/Microsoft.Compute/virtualMachines/VirtualMachineSM” -Threshold “80” -TimeAggregationOperator Average -WindowSize “02:00:00” -Action $action -Description “This rule sends out alert if total requests are exceeded beyond 80”
# Get list of locations and select one.
Get-AzureRmLocation | select Location 
$location = "westeurope"

# Create a new resource group.
$resourceGroup = "smartmonitorSA"
New-AzureRmResourceGroup -Name $resourceGroup -Location $location 

# Set the name of the storage account and the SKU name. 
$storageAccountName = "smstorage1"
$skuName = "Standard_LRS"

# Create the storage account.
$storageAccount = New-AzureRmStorageAccount -ResourceGroupName $resourceGroup `
  -Name $storageAccountName `
  -Location $location `
  -SkuName $skuName

  # Set the name of the storage account and the SKU name. 
$storageAccountName = "smstorage2"
$skuName = "Standard_LRS"

# Create the storage account.
$storageAccount = New-AzureRmStorageAccount -ResourceGroupName $resourceGroup `
  -Name $storageAccountName `
  -Location $location `
  -SkuName $skuName

# Retrieve the context. 
$ctx = $storageAccount.Context
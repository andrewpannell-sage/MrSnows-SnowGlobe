$title = "<<The holy script>> "
$title2 = ""
$host.UI.RawUI.WindowTitle = $title + $title2
Clear-Host
Write-Host


$output=""


While ($true)
    {

Clear-Host
Write-Host
"      __________"
"     < Hello!!! >"
"      ----------"
"             \   ^__^"
"              \  (oo)\_______"
"                 (__)\       )\/\"
"                     ||----w |"
"                     ||     ||"


""
""
""
"Get out of program and close screen: exit"
"1: Random IP"
"2: Info"
"3: blah blah"
"4: blah blah"
"5: blah blah"
""

$number = "0"
$output
$output=""
""
	$number = Read-Host 'What do you want to do?'
	if ($number -eq "0") {
    $output =  "You must type a number or exit!"
	}
    
	elseif ($number -eq "1") {
	
		powershell -executionpolicy Bypass .\NewIP.ps1
		$computerIP = get-WmiObject Win32_NetworkAdapterConfiguration|Where {$_.Ipaddress.length -gt 1}
		$output =  "Ip changed to: " + $computerIP.ipaddress[0]
		
    }
	
	elseif ($number -eq "2") {
	
		$output =  powershell -executionpolicy Bypass .\info.ps1
		
    }
	
	elseif ($number -eq "3") {
		$output =  "You must type!"
		
    }
	
	elseif ($number -eq "4") {
		$output =  "You must type!"
		
    }
	
	elseif ($number -eq "5") {
		$output =  "You must type!"
		
    }
	
	elseif ($number -eq "exit") {
		break
    }
		

    }
exit

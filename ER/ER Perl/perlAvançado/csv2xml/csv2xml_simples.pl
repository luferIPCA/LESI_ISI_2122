open FILE, "carros.csv";
my $n=0;
print "<?xml version=\"1.0\"?>\n";
print"<rentcar>\n";	# XML root element
while (<FILE>)
{
	chomp $_;										# remove \n
	if ($n == 0) 
	{ 
		@tags = split (/;/); 
		$n++; 
		next; 
	}	#1º linha contém o nome das colunas
	
	@valores = split /;/;
	$i = 0;
	
	print "<carro>\n";
	foreach $valor (@valores)
	{
		print "<$tags[$i]>$valor</$tags[$i]>\n"; $i++;
	}
	print "</carro>\n";
}
print "</rentcar>\n";
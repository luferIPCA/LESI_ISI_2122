#!c:\perl\bin\perl.exe
#by lufer

if ($#ARGV == 1)# Precisamos de um argumento como MAINTAG 
{
	$maintag = $ARGV[0];
	$objtag = $ARGV[1];
}
else
{
	print "Usage:\n\tperl csv2xml.pl [maintag] [object] < file.csv\n\n";	# Mostra a sintaxe do script 
	exit -1;
}	

# Começa a gerar o XML
print "<wml>\n";									# Prolog
print "<card>\n";									# elemento raíz

$n=0;
while (<STDIN>)
{
	chomp;													# Elimina o \n no ultimo elemento
	
	if ($n==0) {										# Ignorar a 1ª linha
		$n++;
		next;
	}
     # as restantes linhas são dados para as diferentes colunas, separados por ";"
	@fields = split /;/g;						# Separa por ';' e insere todas as partes num vector 

	print "\n<br/>\n";							# Abre um novo objecto
	
	$i = 0;	
	
	foreach $field (@fields)
	{
		print " $field -";
	}
}
print "</card>\n";				# Fecha a tag do objecto

print "</wml>\n"						# Fecha a tag raíz

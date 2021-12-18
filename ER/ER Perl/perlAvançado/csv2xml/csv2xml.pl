#!c:\perl\bin\perl.exe
#by lufer
#validações
if ($#ARGV == 1)											# Precisamos de um argumento como MAINTAG 
{
	$maintag = $ARGV[0];
	$objtag = $ARGV[1];
}
else
{
	print "Usage:\n\tperl csv2xml.pl [maintag] [object] < file.csv\n\n";	# Mostra a sintaxe do script 
	exit -1
}	
# Começa a gerar o XML
print "<?xml version=\"1.0\" ?>\n";		# Prolog
print "<$maintag>\n";									# elemento raíz

$n=0;
while (<STDIN>)
{	
	chomp;															# Elimina o \n no ultimo elemento
     																	# as restantes linhas são dados para as diferentes colunas, separados por ";"
	@fields = split (/;/g,$_);					# Separa por ';' e insere todas as partes num vector 

	# a primeira linha de um csv possui o nome das colunas
	if ($n == 0)											# Se é a primeira vez, guardar os nomes e não escrever
	{
		$n++;
		@tags = @fields; 									# array com o nome das tags. Encontra-se na primeira linha do csv
		next;
	}	
	# continua a gerar o XML
	print "\t<$objtag>\n";							# Abre um novo objecto
	
	$i = 0;	
	foreach $field (@fields)
	{
		print "\t\t<$tags[$i]>$field</$tags[$i++]>\n";	# Insere informação sobre o objecto
	}
	print "\t</$objtag>\n";							# Fecha a tag do objecto
}
print "</$maintag>\n"									# Fecha a tag raíz



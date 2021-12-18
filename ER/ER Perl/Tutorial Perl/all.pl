#!/usr/bin/perl
#by lufer

#Arrays

@nomes=();
@nomes=(1,2,3,4,5,6);
#Mostra array
foreach $i (@nomes){
	print "\$i=$i\n";
}

#acrescentar valores
push(@nomes,12);
showArray(@nomes);
pop(@nomes);
showArray(sort(@nomes));
showArray((1..10));


#Hash Tables

%hash =();
$hash{1}=2;
$hash{2}=3;

#h1: mostra hash
foreach $x (keys(%hash)){
	print "$hash{$x}\n";
}
#h2: mostra hash
while (($key, $value) = each(%hash)) {

      print("$key = $value\n");

}
#h3:mostra hash
map {
	print "Key=$_ : Value=";
	print $hash{$_}."\n";
} reverse keys(%hash);


#Manipulação de Ficheiros
#dir
while (<*.pl>){
        print "$_\n";
}

#ler do teclado...
print "Insira algo:";
while (<STDIN>) {
#ou while (<>) {
    chomp;        
    last if (length ($_)==0);
    print "Inseriu: $_\n";
  }



#invocar métodos
#showFileLines("exe1.pl","exe1LN.pl");
#showFile("all.pl");
print "Existem " . countWords("all.pl","sub"). " palavras \"sub\" em \"all.pl\"";


#-----------------------------------------------------------------
#métodos

#mostra conteúdo de ficheiro
sub typeFile{
       open(INPUT, "<exe8.pl");
       while (<INPUT>) {
         print "$_\n";
        }
        close(INPUT);
}



#output para ecrã de conteúdo de ficheiro
sub showFile{
	$fName=$_[0];
	open FILE, $fName || die $!;	#ou "or"
	# ou
	#open (FILE,$fName);
  while (<FILE>) {
  		print $_;
	}
  close FILE or die $!;
}

#output de conteúdo de ficheiro para outro ficheiro
sub showFileLines{
	$fName=$_[0];
  $fOutName=$_[1];

	open FILE, $fName or die $!;
  open FOUT, ">$fOutName" or die$!;
  #ou
  #open FOUT, ">",$fOutName" or die$!;
  #> 	write
  #< 	read
  #>>	append
	my @lines = <FILE>;
  $lc=1;
	foreach $l (@lines){
        	print FOUT "$lc\t$l";
          $lc++;
	}
  close FOUT or die $!;
        close FILE or die $!;
}

#Função que conta ocorrência de palavras num ficheiro
sub countWords{
	$fName=$_[0];	#fileName
	$word=$_[1];	#word a encontrar
  $c=0;
	open FILE, $fName or die $!;
  while (<FILE>) {
  	if(/$word/i)	
  	{
    	$c++;
    }
	}
  close FILE or die $!;
  return ($c);
}

#mostra conteúdo de um array
sub showArray{
        @arr=@_;
        $c=0;
        foreach $x (@arr){
              	print "[$c]=$x\n";
              	$c++;
        }
}
#!/usr/bin/perl 
# Author(s) : lufer 
# ISI
#-------------------------------------------------

$name="";
$FIN = "<exe1.pl";	
open FIN;

$FOUT = ">exe1.html";
open FOUT;

$pri=0;
print FOUT "<html><body> ";
while (<FIN>) {
		chomp;
		if (/print/ig) {
			$pri++;			
		}
		if (/^(\#\s?)?Disciplina:\s+(.*)/i){
			$disc=$2;
		}
		if (/^(\#\s?)Ano lectivo:\s+(\d+)\-(\d+)(.*)/i){
			$anolect=$2 . "-" . $3;
		}
		if (/^(\#\s?)Docente:\s+([a-zA-Z\.αινσΰγυ ]+)/i){
		#if (/^(\#\s?)Docente:(.*)/){
			print "Existe";
			$doce=$2;		
		}
}
close FIN;
print FOUT "Prints: $pri<br/>\n";
print FOUT "Disciplina: $disc<br/>\n";
print FOUT "Professor: $doce<br/>\n";
print FOUT "Ano lectivo: $anolect<br/>\n";
print FOUT "\n</BODY></HTML>\n";
close FOUT;

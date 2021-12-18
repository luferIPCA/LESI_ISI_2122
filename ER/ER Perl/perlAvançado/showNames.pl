#!c:/Perl/bin/perl.exe

print "Content-type: text/html\n\n";

$path="E:\\wamp\\www\\cgi-bin\\Docentes";	#ALTERAR
opendir(DIR, "$path") || die "Não consigo abrir \.\/\/$path: $!";
@files = grep {-d "$path/$_" } readdir(DIR);
closedir DIR;


#Desenha form:

print "<h1>INICIO</h1>";

#while (<*.*>){
foreach(@files){
	chomp;
	next if ($_=="." || $_=="..");
	print "\<a href=\"$path\\$_\" target=\"new\">$_<\/a><br/>";
	
}
print "done.\n";




#!d:\perl\bin\perl -w
# --------------------------------------------------------------------
# Perl by example
# exemplos de Perl (6)
# Hash Tables
# by lufer
# --------------------------------------------------------------------

%meses=("jan"=>1,"fev"=>2);

while (($key, $value) = each(%meses)) {

      print("$key = $value\n");

}

print (exists($meses{"mar"}) ? "yes\n":"no\n");

map {
	print "$_\n";
} sort keys(%meses);

map {
	print "$_";
	print $meses{$_}."\n";
} reverse keys(%meses);

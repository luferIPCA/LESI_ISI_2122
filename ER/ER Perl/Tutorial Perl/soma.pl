#teste de argumentos
#-------------------

#int soma(int x, int y) { return(x+y);}

soma(12,3);

sub soma{
	($x,$y)=@_;
# ou
#	$x=$_[0];
#        $y=$_[1];
	print "Total= " .($x+$y)."\n";
}


#função e_par: int --> bool
#e_par(int x){print((x%2) ? "Impar":"Par");}

$v=33;
$y=e_par($v);

sub e_par{
	$x=$_[0];
	print " O numero $x e " . (($x%2) ? "Impar" : "Par") . "\n";
}
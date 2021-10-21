cs() {
        if [ "$1" ]
        then
                cd "$1"
                pwd > $HOME/.cs
        else
                cd `cat $HOME/.cs`
        fi
}

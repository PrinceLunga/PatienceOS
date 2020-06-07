import React, { Component } from 'react'

 class Groups extends Component {

    
    constructor(props){
        super(props);
        this.state = {
            groups : []
        }
    }

    componentWillMount(){
        fetch('https://localhost:5001/api/Group/GetGroups')
        .then( res => res.json())
        .then( data => this.setState({groups: data}));
    }
    render() {
        
        
    const groupItem = this.state.groups.map( group => (
        <table>
                <tr>
                    <td>
                    <p>{group.id} |</p>
                    </td>

                    <td>
                    <p>{group.name} |</p>
                    </td>

                    <td>
                    <p>{group.description} |</p>
                    </td>
                </tr>
        </table>
    ))


        return (
        <div>
            <h1>Groups</h1>
            {groupItem}
        </div>
        )
    }
}
export default Groups;

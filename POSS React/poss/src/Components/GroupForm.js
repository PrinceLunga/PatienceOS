import React, { Component } from 'react';

class GroupForm extends Component {

    constructor(props){
        super(props);
        this.state = {
            // id : '',
            name : '',
            description : ''
        };
        this.onChange = this.onChange.bind(this);
        this.onsubmit = this.onsubmit.bind(this);
    }

    onChange(e){
        this.setState({[e.target.name]: e.target.value});
    }


    onsubmit(e){
        e.preventDefault();

        const post = {
            name : this.state.name,
            description : this.state.description
        }

        fetch('https://localhost:5001/api/Group/PostGroup', {
            method : 'POST',
            headers : {
                'content-type':'application/json'
            },
            body : JSON.stringify(post)
        })
        .then(res => res.JSON())
        .then(data => console.log(data));
    }


    render() {
        return (
            <div>
                <h1>Add Groups</h1>
                <form onSubmit={this.onSubmit}>
                    <div>
                        <label >Name</label> <br/>
                        <input 
                            type="text" 
                            name="name"
                            onChange={this.onChange} 
                            value={this.state.name} />
                    </div>
                    
                    
                    <div>
                        <label >Description</label> <br/>
                        <input 
                             type="text" 
                             name="description"
                             onChange={this.onChange} 
                             value={this.state.description} />
                    </div>

                    <br/>
                    <button type="submit">Submit</button>
                </form>
            </div>
        )
    }
}
export default GroupForm;
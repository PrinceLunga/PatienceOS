import React, { Component } from 'react'

class PostForm extends Component {
   
    constructor(props){
        super(props);
        this.state = {
            id : '',
            name : '',
            group : '',
            subgroup : '',
            status : ''
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
            id : this.state.id,
            name : this.state.name,
            group : this.state.group,
            subggroup : this.state.subgroup,
            status : this.state.status  
        }

        fetch('https://localhost:44374/api/Products', {
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
                <h1>Add Post</h1>
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
                        <label >Group</label> <br/>
                        <input 
                            type="text" 
                            name="group"
                            onChange={this.onChange} 
                            value={this.state.group}  />
                    </div>

                    <div>
                        <label >Subgroup</label> <br/>
                        <input 
                             type="text" 
                             name="subgroup"
                             onChange={this.onChange} 
                             value={this.state.subgroup} />
                    </div>

                    <div>
                        <label >Status</label> <br/>
                        <input 
                             type="text" 
                             name="status"
                             onChange={this.onChange} 
                             value={this.state.status} />
                    </div>
                    <br/>
                    <button type="submit">Submit</button>
                </form>
            </div>
        )
    }
}

export default PostForm;
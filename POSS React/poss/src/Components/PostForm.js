import React, { Component } from 'react'

class PostForm extends Component {
   
    constructor(props){
        super(props);
        this.state = {
            // id : '',
            name : '',
            group : '',
            subgroup : '',
            status : '',
            quantity : '',
            price : '',
            description : '',
            image : ''
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
            group : this.state.group,
            subggroup : this.state.subgroup,
            status : this.state.status,
            quantity : this.state.quantity,
            price : this.state.price,
            description : this.state.description,
            image : this.state.image 
        }

        fetch('https://localhost:5001/api/Products/PostProducts', {
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

                    <div>
                        <label >Quantity</label> <br/>
                        <input 
                             type="text" 
                             name="quantity"
                             onChange={this.onChange} 
                             value={this.state.quantity} />
                    </div>

                    <div>
                        <label >Price</label> <br/>
                        <input 
                             type="text" 
                             name="price"
                             onChange={this.onChange} 
                             value={this.state.price} />
                    </div>

                    <div>
                        <label >Description</label> <br/>
                        <input 
                             type="text" 
                             name="description"
                             onChange={this.onChange} 
                             value={this.state.description} />
                    </div>

                    <div>
                        <label >Image</label> <br/>
                        <input 
                             type="text" 
                             name="image"
                             onChange={this.onChange} 
                             value={this.state.image} />
                    </div>
                    <br/>
                    <button type="submit">Submit</button>
                </form>
            </div>
        )
    }
}

export default PostForm;
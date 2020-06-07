import React, { Component } from 'react';

 class Posts extends Component {

    constructor(props){
        super(props);
        this.state = {
            posts : []
        }
    }

    componentWillMount(){
        fetch('https://localhost:5001/api/Products/GetProducts')
        .then( res => res.json())
        .then( data => this.setState({posts: data}));
    }

    render() {
        
        
        const postItems = this.state.posts.map( post => (
           

        <table>
            <thead>
                
            </thead>
                <tr>
                    <td>
                        <p>{post.id} |</p>
                    </td>
                    <td>
                        <p>{post.name} |</p>
                    </td>
                    <td>
                    <p>{post.group} |</p>
                    </td>
                    <td>
                    <p>{post.subGroup} |</p>
                    </td>

                    <td>
                    <p>{post.status}</p>
                    </td>

                    <td>
                    <p>{post.quantity}</p>
                    </td>

                    <td>
                    <p>{post.price}</p>
                    </td>

                    <td>
                    <p>{post.desription}</p>
                    </td>

                    <td>
                    <p>{post.image}</p>
                    </td>
                </tr>
        </table>

        ))
        return (
            <div>
                <h1>Posts</h1>
                {postItems}
            </div>
        )
    }
}
export default Posts;
     
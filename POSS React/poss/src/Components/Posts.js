import React, { Component } from 'react';

 class Posts extends Component {

    constructor(props){
        super(props);
        this.state = {
            posts : []
        }
    }

    componentWillMount(){
        fetch('https://localhost:44374/api/Products')
        .then( res => res.json())
        .then( data => this.setState({posts: data}));
    }

    render() {
        
        
        const postItems = this.state.posts.map( post => (
           

        <table>
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
     
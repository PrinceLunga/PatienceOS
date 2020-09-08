// import React from 'react';
// import logo from './logo.svg';
// import './App.css';

// import Posts from './Components/Posts';
// import PostForm from './Components/PostForm';
// import Groups from './Components/Groups';
// import GroupForm from './Components/GroupForm';

// function App() {
//   return (
//     <div className="App">
//       <header className="App-header">
//         <img src={logo} className="App-logo" alt="logo" />
//         <p>
//           Edit <code>src/App.js</code> and save to reload.
//         </p>
//         <a
//           className="App-link"
//           href="https://reactjs.org"
//           target="_blank"
//           rel="noopener noreferrer"
//         >
//           Learn React
//         </a>
//       </header>
//       <PostForm />
      
//       <hr/>
//       <Posts />

//       <hr/>
//       <Groups />

//       <hr/>
//       <GroupForm />
//     </div>

//   );
// }

// export default App;


import React from 'react';
import './App.css';
import Navbar from './components/Navbar';
import Home from './components/Home';
import  Cart  from './components/Cart';
// import Groups from './components/Groups';
import { Provider } from 'react-redux';
import store from './store.js';
import { BrowserRouter, Route, Switch } from 'react-router-dom';

function App() {
  return (
    <Provider store={store}>
      <div className="App">
        <BrowserRouter>
        <Navbar />
          <Switch>
            <Route exact path="/" component={Home} />
            <Route path="/Cart" component={Cart} />
            {/* <Route path="/Groups" component={Groups} /> */}
          </Switch>
        </BrowserRouter>
      </div>
    </Provider>
  );
}

export default App;
